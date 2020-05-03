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
  Button,
  Modal, 
  ModalHeader, 
  ModalBody, 
  ModalFooter, 
  ModalTitle
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
    },[]);


    

   

  
    const editarEmpleado = (id) => {
      asignarCambio(id);
      console.log("Editando Empleado" + cambio);
    
      
    }

    const eliminarEmpleado = (id) => {
      console.log("Eliminando Empleado " + id) ;
    }

    const addEmpleado = () => {
      console.log("Agregando Empleado ");
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
              <Button className="btn-primary" onClick={() => addEmpleado()}>Agregar Empleado</Button>
            </Col>
          </Row>
        

          {/* <div>
      <Button color="danger" onClick={toggle}>Hola</Button>
      <Modal isOpen={modal} toggle={toggle} className>
        <ModalHeader toggle={toggle}>Modal title</ModalHeader>
        <ModalBody>
        <p>
                                <span className="modal-lable">Nombre:</span>
                                    <input 
                                        type="text" 
                                        name="nombre"
                                        id="nombre" 
                                        placeholder="Nombre"
                                        value={empleado.nombre}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Apellido:</span>
                                    <input 
                                        type="text" 
                                        name="apellido"
                                        id="apellido" 
                                        placeholder="Apellido"
                                        value={empleado.apellido}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Direccion:</span>
                                    <input 
                                        type="text" 
                                        name="direccion"
                                        id="direccion" 
                                        placeholder="Direccion"
                                        value={empleado.direccion}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Edad:</span>
                                    <input 
                                        type="text" 
                                        name="edad"
                                        id="edad" 
                                        placeholder="Edad"
                                        value={empleado.edad}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Nomina:</span>
                                    <input 
                                        type="text" 
                                        name="nomina"
                                        id="nomina" 
                                        placeholder="Nomina"
                                        value={empleado.nomina}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Tipo De Nomina:</span>
                                    <input 
                                        type="text" 
                                        name="tipoNomina"
                                        id="tipoNomina" 
                                        placeholder="Tipo De Nomina"
                                        value={empleado.tipoNomina}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Telefono:</span>
                                    <input 
                                        type="text" 
                                        name="telefono"
                                        id="telefono" 
                                        placeholder="Telefono"
                                        value={empleado.telefono}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Email:</span>
                                    <input 
                                        type="text" 
                                        name="email"
                                        id="email" 
                                        placeholder="Email"
                                        value={empleado.email}
                                        onChange={onChange}
                                    />
                            </p>
                            <p>
                                <span className="modal-lable">Posicion:</span>
                                    <input 
                                        type="text" 
                                        name="posicion"
                                        id="posicion" 
                                        placeholder="Posicion"
                                        value={empleado.posicion}
                                        onChange={onChange}
                                    />
                            </p>
        </ModalBody>
        <ModalFooter>
          <Button color="primary" onClick={toggle}>Do Something</Button>{' '}
          <Button color="secondary" onClick={toggle}>Cancel</Button>
        </ModalFooter>
      </Modal>
    </div> */}

        </div> 
      </>

    );
  }


export default withRouter(EmpleadoList);
