import React, {useState, useEffect } from 'react';

import axios from "axios";

import { withRouter } from 'react-router-dom';
import Alerta from './Alerta.js';

import {
    Card,
    CardHeader,
    CardBody,
    CardTitle,
    Table,
    Row,
    Col,
    Button,
    FormGroup,
    Input,
    Modal, 
    ModalHeader, 
    ModalBody, 
    ModalFooter
    //Toast, ToastBody, ToastHeader
  } from "reactstrap";

function ModalEdit(props) {

    const [empleado, agregarEmpleado] = useState({id: '', nombre: '', apellido: '', direccion: '', edad: '', nomina: '',  tipoNomina: '', telefono: '', email: '', posicion: ''});

    const [modal, setModal] = useState(false);

    const toggle = () => setModal(!modal);
    
    const apiUrl = "https://localhost:44376/api/Empleado/" + props.item;

    useEffect(() => {
        const obtenerDatos = async () => {
        const resultado = await axios(apiUrl);
        agregarEmpleado(resultado.data);
        };
        obtenerDatos();
        console.log(apiUrl);
    },[]);

    const EditarEmpleado = (e) => {

        //e.preventDefault();

        const data = {id: empleado.id, nombre: empleado.nombre, apellido: empleado.apellido, direccion: empleado.direccion, edad: parseInt(empleado.edad), nomina: parseInt(empleado.nomina), tipoNomina: empleado.tipoNomina, telefono: parseInt(empleado.telefono), email: empleado.email, posicion: empleado.posicion };

        axios.put(apiUrl, data)
            .then((result) => {  
             console.log(result.data);
            //props.history.push('/admin/empleados' + data.id); 
            setModal(false); 
            //props.history.push('/admin/empleados');
            
            alert("Empleado Actualizado");
            window.location.reload();
            })
        .catch((error) => 
            console.log( error.response ) ); 


    }

    

    const onChange = (e) => {

        e.persist();

        agregarEmpleado({...empleado, [e.target.name] : e.target.value });
        console.log(empleado);
    }
    

   
        return (
           <div className="content">        
               <Button className="btn-warning mr-1" onClick={toggle}>Editar</Button>
            <Modal className="special_modal" isOpen={modal} toggle={toggle}>
                <ModalHeader className="special_header" toggle={toggle}>Editar Empleado</ModalHeader>
                <ModalBody>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="nombre"
                                id="nombre" 
                                placeholder="Nombre"
                                value={empleado.nombre}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="apellido"
                                id="apellido" 
                                placeholder="Apellido"
                                value={empleado.apellido}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                </Row>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="direccion"
                                id="direccion" 
                                placeholder="Direccion"
                                value={empleado.direccion}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="edad"
                                id="edad" 
                                placeholder="Edad"
                                value={empleado.edad}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                </Row>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="nomina"
                                id="nomina" 
                                placeholder="Nomina"
                                value={empleado.nomina}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="tipoNomina"
                                id="tipoNomina" 
                                placeholder="Tipo De Nomina"
                                value={empleado.tipoNomina}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                </Row>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="telefono"
                                id="telefono" 
                                placeholder="Telefono"
                                value={empleado.telefono}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="email"
                                id="email" 
                                placeholder="Email"
                                value={empleado.email}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                </Row>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="text" 
                                name="posicion"
                                id="posicion" 
                                placeholder="Posicion"
                                value={empleado.posicion}
                                onChange={onChange}
                            />
                        </FormGroup> 
                    </Col>
                    <Col className="md-6">
                        <FormGroup>
                            
                        </FormGroup> 
                    </Col>
                </Row>
                </ModalBody>
                <ModalFooter>
                    <Button color="primary" onClick={() => EditarEmpleado()}>Editar Empleado</Button>{' '}
                    <Button color="secondary" onClick={toggle}>Cancelar</Button>
                </ModalFooter>
            </Modal>
            </div>
            
            // <div className="modal fade show" id="exampleModal" tabIndex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
            //     <div className="modal-dialog" role="document">
            //         <div className="modal-content">
            //             <div className="modal-header">
            //                 <h5 className="modal-title" id="exampleModalLabel">Editar Empleado</h5>
            //                 <button type="button" className="close" data-dismiss="modal" aria-label="Close">
            //                     <span aria-hidden="true">&times;</span>
            //                 </button>
            //             </div>
            //             <div className="modal-body">
            //                 <p>
            //                     <span className="modal-lable">Nombre:</span>
            //                         <input 
            //                             type="text" 
            //                             name="nombre"
            //                             id="nombre" 
            //                             placeholder="Nombre"
            //                             value={empleado.nombre}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Apellido:</span>
            //                         <input 
            //                             type="text" 
            //                             name="apellido"
            //                             id="apellido" 
            //                             placeholder="Apellido"
            //                             value={empleado.apellido}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Direccion:</span>
            //                         <input 
            //                             type="text" 
            //                             name="direccion"
            //                             id="direccion" 
            //                             placeholder="Direccion"
            //                             value={empleado.direccion}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Edad:</span>
            //                         <input 
            //                             type="text" 
            //                             name="edad"
            //                             id="edad" 
            //                             placeholder="Edad"
            //                             value={empleado.edad}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Nomina:</span>
            //                         <input 
            //                             type="text" 
            //                             name="nomina"
            //                             id="nomina" 
            //                             placeholder="Nomina"
            //                             value={empleado.nomina}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Tipo De Nomina:</span>
            //                         <input 
            //                             type="text" 
            //                             name="tipoNomina"
            //                             id="tipoNomina" 
            //                             placeholder="Tipo De Nomina"
            //                             value={empleado.tipoNomina}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Telefono:</span>
            //                         <input 
            //                             type="text" 
            //                             name="telefono"
            //                             id="telefono" 
            //                             placeholder="Telefono"
            //                             value={empleado.telefono}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Email:</span>
            //                         <input 
            //                             type="text" 
            //                             name="email"
            //                             id="email" 
            //                             placeholder="Email"
            //                             value={empleado.email}
            //                             onChange={onChange}
            //                         />
            //                 </p>
            //                 <p>
            //                     <span className="modal-lable">Posicion:</span>
            //                         <input 
            //                             type="text" 
            //                             name="posicion"
            //                             id="posicion" 
            //                             placeholder="Posicion"
            //                             value={empleado.posicion}
            //                             onChange={onChange}
            //                         />
            //                 </p>
                            
                            
            //             </div>
            //             <div className="modal-footer">
            //                 <button type="button" className="btn btn-secondary" data-dismiss="modal">Cerrar</button>
            //                 <button type="button" className="btn btn-primary" data-dismiss="modal" onClick={EditarEmpleado}>Guardar</button>
            //             </div>
            //         </div>
            //     </div>
            // </div>
        );
    
}

export default withRouter(ModalEdit);


    
    