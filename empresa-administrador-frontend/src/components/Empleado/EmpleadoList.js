import React, {useState, useEffect } from "react";

import axios from "axios";

//import EmpleadoAdd from './EmpleadoAdd';

import Popup from "reactjs-popup";

import { withRouter }  from "react-router-dom";

import EmpleadoAdd from "./EmpleadoAdd";

// reactstrap components
import {
  Card,
  CardHeader,
  CardBody,
  CardTitle,
  Table,
  Row,
  Col,
  Button,
  Modal, 
  ModalHeader, 
  ModalBody, 
  ModalFooter
} from "reactstrap";

function EmpleadoList(props)  {

    const [datos, asignarDatos] = useState([]);

    const apiUrl = "https://localhost:44376/api/Empleado";

    useEffect(() => {
        const obtenerDatos = async () => {
            const resultado = await axios(apiUrl);
            asignarDatos(resultado.data);
            

        };
        obtenerDatos();
    },[]);

    const [modal, setModal] = useState(false);

    const toggle = () => setModal(!modal);

  


  
    return (
      <>
        <div className="content">
          <Row>
            <Col md="12">
              <Card>
                <CardHeader>
                  <CardTitle tag="h4">Lista De Empleados</CardTitle>
                </CardHeader>
                <Button className="warning" onClick={toggle}></Button>
         
        
   
                <CardBody>
                  <Table className="tablesorter" responsive>
                    <thead className="text-primary">
                      <tr>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th className="text-center">Direccion</th>
                        <th>Edad</th>
                        <th>Nomina</th>
                        <th>Tipo De Nomina</th>
                        <th>Telefono</th>
                        <th className="text-center">Email</th>
                        <th>Posicion</th>
                        <th>Acciones</th>
                      </tr>
                    </thead>
                    <tbody>
                        {datos && datos.map(item => 
                      <tr key={item.id}>
                        <td>{item.nombre}</td>
                        <td>{item.apellido}</td>
                        <td className="text-center">{item.direccion}</td>
                        <td>{item.edad}</td>
                        <td>{item.nomina}</td>
                        <td>{item.tipoNomina}</td>
                        <td>{item.telefono}</td>
                        <td className="text-center">{item.email}</td>
                        <td>{item.posicion}</td>
                      </tr>
                      )}
                    </tbody>
                  </Table>
                </CardBody>
              </Card>
            </Col>
          </Row>
        </div>
      </>
    );
  }


export default withRouter(EmpleadoList);
