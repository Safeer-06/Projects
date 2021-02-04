<?php
/**
 * The base configuration for WordPress
 *
 * The wp-config.php creation script uses this file during the
 * installation. You don't have to use the web site, you can
 * copy this file to "wp-config.php" and fill in the values.
 *
 * This file contains the following configurations:
 *
 * * MySQL settings
 * * Secret keys
 * * Database table prefix
 * * ABSPATH
 *
 * @link https://wordpress.org/support/article/editing-wp-config-php/
 *
 * @package WordPress
 */

// ** MySQL settings - You can get this info from your web host ** //
/** The name of the database for WordPress */
define( 'DB_NAME', 'safeertestingsite' );

/** MySQL database username */
define( 'DB_USER', 'root' );

/** MySQL database password */
define( 'DB_PASSWORD', '' );

/** MySQL hostname */
define( 'DB_HOST', 'localhost' );

/** Database Charset to use in creating database tables. */
define( 'DB_CHARSET', 'utf8mb4' );

/** The Database Collate type. Don't change this if in doubt. */
define( 'DB_COLLATE', '' );

/**#@+
 * Authentication Unique Keys and Salts.
 *
 * Change these to different unique phrases!
 * You can generate these using the {@link https://api.wordpress.org/secret-key/1.1/salt/ WordPress.org secret-key service}
 * You can change these at any point in time to invalidate all existing cookies. This will force all users to have to log in again.
 *
 * @since 2.6.0
 */
define( 'AUTH_KEY',         '05ZS?[8qbIz.-fB)P!MnNrU~Sg85oXAcernVNb(Sur%pma=k0NjXCQo{,+qP1-!:' );
define( 'SECURE_AUTH_KEY',  'YV#hV:g9`MY^kTi3H*Kgfp8^ic]^]#G]tFV] lnJ3Fs^E.#=o|.dy7;0}JZK7{E@' );
define( 'LOGGED_IN_KEY',    'b<+gt>kGFIz.*w#CTVe-p+DK9k5n%i0UVE6F6_)N$9JgJ=g.Otm$w~:wr]qzcG<_' );
define( 'NONCE_KEY',        'yv8&G6#xc|-OP/17xCD>R$2%_HbZ~pmj<e;m1jvh&aai~Og3;h25NB2_33nT8*-V' );
define( 'AUTH_SALT',        '3lY]cTt[/$W8BxN5w(VI92au!Ye|dd#--~gIm<I`GEzn~=~vuSRi,Cd=>W<9fy~E' );
define( 'SECURE_AUTH_SALT', '?gldHAQgMAicqv`PsZTM75;5,(itR<*INry r;SfwTtsg7/k&1YeH8W~ZPweK=lM' );
define( 'LOGGED_IN_SALT',   '1Z;D?R7}nFap,l-Nnwc9nSPYz}#$d[SHhce[)I[K<mM7`g]p#&I8nwE?5i,=+6wc' );
define( 'NONCE_SALT',       'MO2PQarz7k6)b#3{lfi$[Pt?ixJuoi]d6onz*Fn}*HQHRzaM(@RyfHx!lcUIs2[/' );

/**#@-*/

/**
 * WordPress Database Table prefix.
 *
 * You can have multiple installations in one database if you give each
 * a unique prefix. Only numbers, letters, and underscores please!
 */
$table_prefix = 'wp_';

/**
 * For developers: WordPress debugging mode.
 *
 * Change this to true to enable the display of notices during development.
 * It is strongly recommended that plugin and theme developers use WP_DEBUG
 * in their development environments.
 *
 * For information on other constants that can be used for debugging,
 * visit the documentation.
 *
 * @link https://wordpress.org/support/article/debugging-in-wordpress/
 */
define( 'WP_DEBUG', false );

/* That's all, stop editing! Happy publishing. */

/** Absolute path to the WordPress directory. */
if ( ! defined( 'ABSPATH' ) ) {
	define( 'ABSPATH', __DIR__ . '/' );
}

/** Sets up WordPress vars and included files. */
require_once ABSPATH . 'wp-settings.php';
