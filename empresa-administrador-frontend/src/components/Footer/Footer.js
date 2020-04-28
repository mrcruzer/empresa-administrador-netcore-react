
/*eslint-disable*/
import React from "react";
// used for making the prop types of this component
import PropTypes from "prop-types";

// reactstrap components
import { Container, Row, Nav, NavItem, NavLink } from "reactstrap";

class Footer extends React.Component {
  render() {
    return (
      <footer className="footer">
        <Container fluid>
          <Nav>
            <NavItem>
              <NavLink href="#">Inicio</NavLink>
            </NavItem>
            <NavItem>
              <NavLink href="">Sobre Nosotros</NavLink>
            </NavItem>
            <NavItem>
              <NavLink href="#">Blog</NavLink>
            </NavItem>
          </Nav>
          <div className="copyright">
            © {new Date().getFullYear()} {" "}
            <i className="tim-icons icon-heart-2" /> by{" "}
            <a
              href="#"
              target="_blank"
            >
             
            </a>{" "}
           
          </div>
        </Container>
      </footer>
    );
  }
}

export default Footer;
