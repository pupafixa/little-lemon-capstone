
body {
  width: 100%;
  margin: 0 auto;
}

.logo {
  width: 200px;
  height: 50px;
}

.li {
  list-style: none;
}

a {
  text-decoration: none;
}

nav {
  z-index: 10001;
}

.navbar {
  padding: 10px 13%;
  display: flex;
  justify-content: space-between;
  align-items: center;
}

.navbar .logo {
  margin-right: auto; /* Aligns logo to the left */
}

nav ul li {
  display: inline-block;
  padding: 1em;
}

nav ul li a {
  color: #000;
}

nav ul li a:hover {
  text-decoration: underline solid #495e57;
}

.menu-icon {
  display: none; /* Hidden by default, visible in mobile view */
  cursor: pointer;
}

.bar {
  width: 25px;
  height: 3px;
  background-color: black;
  margin: 5px 0;
}

.nav-links {
  list-style: none;
  display: flex;
  align-items: center;
}

@media (max-width: 768px) {
  /* Hide nav-links by default on mobile */
  .nav-links {
    display: none;
    flex-direction: column;
    position: absolute;
    top: 60px;
    right: 0;
height: 300px;
    width: 100%;
    background-color: #495e57;
z-index: 10002;
    transition: all 0.3s ease-in-out;
  }

  /* Show nav-links when 'open' class is added */
  .nav-links.open {
    display: flex;
    flex-direction: column;
    align-items: center;
  }

  /* Make menu icon visible on mobile */
  .menu-icon {
    display: block;
  }

  nav ul li {
    padding: 10px;
    width: 100%;
    text-align: center;


background: #333333;
  }

  nav ul li a {
    color: #fff;
  }

.banner-img{
display:none
}

}


/* header section */

.header {
  background-color: #495e57;
  padding: 40px 0;
}

.header section {
color: #EDEFEE;
padding: 10px 13%;
position: relative;
}


h2 {
  color: #F4CE14;
  font-size: 40px;
}

h3 {
  font-size: 25px;
}

.banner p {
  font-size: 20px;
  max-width: 520px;
  line-height: 1.5;
  margin-bottom: 30px;
}

button {
  background-color: #F4CE14;
  color: black;
  padding: 14px 18px;
  border: none;
  text-decoration: none;
  border-radius: 12px;
  font-size: 20px;
  font-weight: bold;
  cursor: pointer;
}

.banner-img{
  position: absolute;
  right: 5%;
  top: 15%;
  width: 400px;
}

.banner-img img {
  width: 100%;
  height: 400px;
  border-radius: 20px;
}

