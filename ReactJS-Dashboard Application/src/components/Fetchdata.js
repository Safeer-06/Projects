import React, { Component } from "react";

export class FetchData extends Component {
  constructor() {
    super();
  }

  componentDidMount() {
    fetch("https://jsonplaceholder.typicode.com/posts")
      .then((response) => response.json())
      .then((data) => {
        console.log(data);
      });
  }
  render() {
    return (
      <div>
        <h1>test</h1>
      </div>
    );
  }
}

export default FetchData;