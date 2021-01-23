#!/usr/bin/env python
# coding: utf-8

# In[ ]:


# from werkzeug.wrappers import Request, Response
# from flask import Flask

# app = Flask(__name__)

# @app.route("/")
# def hello():
#     return "Hello World!"

# if __name__ == '__main__':
#     from werkzeug.serving import run_simple
#     run_simple('localhost', 9000, app)


# In[ ]:


# from werkzeug.wrappers import Request, Response
from flask import Flask, render_template, request 
from werkzeug import secure_filename 

# from keras.preprocessing.image import ImageDataGenerator 
from tensorflow import keras
import tensorflow as tf 
# import numpy as np 
import numpy
import os 
import cv2 as cv
# import os
import glob

import matplotlib.pyplot as plt
model = keras.models.load_model('ocular_model1.h5')
app = Flask(__name__) 
app.config['UPLOAD_FOLDER'] = 'uploaded/images'


def crop_image_resize(img, ImageSize):
    height, width = img.shape[:2]
    if width == height:
        return cv.resize(img, ImageSize)
        
    length = min(width, height)
    left = (width - length) // 2
    top = (height - length) // 2
    right = (width + length) // 2
    bottom = (height + length) // 2
    return cv.resize(img[top:bottom,left:right], ImageSize)

def read_image(path_of_image):
    img = cv.imread(path_of_image)
    final_image = crop_image_resize(img, (250, 250))
    cv.imwrite(path_of_image,final_image)

@app.route('/') 
def upload_f(): 
    return render_template('template.html') 
def decode_img(img):
    img = tf.io.read_file(img)
    img = tf.image.decode_jpeg(img, channels=3)
    img = tf.image.convert_image_dtype(img, tf.float32)
    return img
def merge_two(left, right):
    final_table = [0, 0, 0, 0, 0, 0, 0, 0]
    counter = 0
    not_n = 0
    for l in left:
        r = right[counter]
        if l>=r:
            final_table[counter] = l
        else:
            final_table[counter] = r
        if (l>0.5 or r >0.5) and counter>0:
            print(l ,r, counter)
            not_n=1
        counter+=1
    if not_n == 1:
        final_table[0] = 0
    return final_table
def finds(): 
    testing_image = app.config['UPLOAD_FOLDER']
    images = [f for f in os.listdir(testing_image) if os.path.splitext(f)[-1] == '.jpg']
    for image in images:
        read_image(app.config['UPLOAD_FOLDER']+"/"+image)

    # import tensorflow as tf
    test_ds = tf.data.Dataset.list_files("uploaded/images/*.jpg", shuffle=False)
    AUTOTUNE = tf.data.experimental.AUTOTUNE
    
    test_ds2 = test_ds.map(decode_img, num_parallel_calls=AUTOTUNE)
    test_ds3 = test_ds2.batch(32)
    predictions = model.predict(test_ds3)
    numpy.set_printoptions(precision=3,  suppress=True)

    f_t = merge_two(predictions[0], predictions[1])
    n=str(f_t[0])
    d=str(f_t[1])
    g=str(f_t[2])
    c=str(f_t[3])
    a=str(f_t[4])
    h=str(f_t[5])
    m=str(f_t[6])
    o=str(f_t[7])
    
    return ("Normal: "+n+"                                                                           "+" Glaucoma: "+g+"                                                             Diabetic retinopathy: "+d+"                                                                              Cataract: "+c+"                                                                                           AMD: "+a+"                                                                                                     Hypertensive Retinopathy: "+h+"                                                                                  Myopia: "+m+"                                                                                         Other: "+o)

@app.route('/uploader', methods = ['GET', 'POST']) 
def upload_file(): 
    if request.method == 'POST': 
        f = request.files['file'] 
        f.save(os.path.join(app.config['UPLOAD_FOLDER'], secure_filename(f.filename)))
        f1 = request.files['file1']
        f1.save(os.path.join(app.config['UPLOAD_FOLDER'], secure_filename(f1.filename)))
        val = finds() 
#         val=""
        
        files = glob.glob(app.config['UPLOAD_FOLDER']+'/*')
        for f in files:
            os.remove(f)
        return render_template('template.html', ss = val) 

# if __name__ == '__main__':
#     from werkzeug.serving import run_simple
#     run_simple('localhost', 9000, app)    
if __name__ == '__main__': 
    app.run()


# In[ ]:




