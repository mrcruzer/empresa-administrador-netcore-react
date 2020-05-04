import React, {useState, useEffect } from "react";

import axios from "axios";

//import EmpleadoAdd from './EmpleadoAdd';

import Popup from "reactjs-popup";

import { withRouter }  from "react-router-dom";

import EmpleadoAdd from "./EmpleadoAdd";

import ModalEdit from './ModalEdit';


// reactstrap components
import {
  Card,
  CardHeader,
  CardBody,
  CardTitle,
  Table,
  Row,
  Col,
  Button
} from "reactstrap";

function EmpleadoList(props)  {

    const [datos, asignarDatos] = useState([]);
    const [cambio, asignarCambio] = useState('');

    const apiUrl = "https://localhost:44376/api/Empleado";

    useEffect(() => {
        const obtenerDatos = async () => {
            const resultado = await axios(apiUrl);
            asignarDatos(resultado.data);
            

        };
        obtenerDatos();

        //ModalEdit.toggle();
    },[datos]);


    

   

  
    const editarEmpleado = (id) => {
      asignarCambio(id);
      //console.log("Editando Empleado" + cambio);
    
      
    }

    const eliminarEmpleado = (id) => {
      console.log("Eliminando Empleado " + id) ;
    }

    


  
    return (
      <>
        <div className="content">
          <Row>
            <Col md="12">
              <Card>
                <CardHeader>
                  <CardTitle tag="h4">Lista De Empleados</CardTitle>
                </CardHeader>
                <CardBody>
                  <Table className="tablesorter" responsive>
                    <thead className="text-primary">
                      <tr>
                        <th>Nombre</th>
                        <th>Apellido</th>
                        <th>Direccion</th>
                        <th>Edad</th>
                        <th>Nomina</th>
                        <th>Tipo De Nomina</th>
                        <th>Telefono</th>
                        <th className="text-center">Email</th>
                        <th>Posicion</th>
                        <th className="text-center">Acciones</th>
                      </tr>
                    </thead>
                    <tbody>
                        {datos && datos.map(item => 
                      <tr key={item.id}>
                        <td>{item.nombre}</td>
                        <td>{item.apellido}</td>
                        <td>{item.direccion}</td>
                        <td>{item.edad}</td>
                        <td>{item.nomina}</td>
                        <td>{item.tipoNomina}</td>
                        <td>{item.telefono}</td>
                        <td className="text-center">{item.email}</td>
                        <td>{item.posicion}</td>
                        <td>
                        <div className="btn-group">
                                
                                <ModalEdit item={item.id}/>
                                <Button type="button" className="btn-danger mr-1" onClick={() => eliminarEmpleado(item.id)}>Eliminar</Button>
                
                            </div>
                        </td>
                      </tr>
                      
                      )}
                    </tbody>
                  </Table>
                 
                </CardBody>
              </Card>
              <EmpleadoAdd />
            </Col>
          </Row>
        </div> 
      </>

    );
  }


export default withRouter(EmpleadoList);
