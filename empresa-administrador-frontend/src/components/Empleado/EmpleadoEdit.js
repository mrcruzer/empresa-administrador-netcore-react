import React, {useState, useEffect } from 'react';

import axios from "axios";

import { withRouter } from 'react-router-dom';

import Swal from "sweetalert2";

import {
    Row,
    Col,
    Button,
    FormGroup,
    Input,
    Modal, 
    ModalHeader, 
    ModalBody, 
    ModalFooter
  } from "reactstrap";

function EmpleadoEdit(props) {

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
        //console.log(apiUrl);
    },[apiUrl]);

    const EditarEmpleado = (e) => {

        //e.preventDefault();

        const data = {id: empleado.id, nombre: empleado.nombre, apellido: empleado.apellido, direccion: empleado.direccion, edad: parseInt(empleado.edad), nomina: parseInt(empleado.nomina), tipoNomina: empleado.tipoNomina, telefono: parseInt(empleado.telefono), email: empleado.email, posicion: empleado.posicion };

        axios.put(apiUrl, data)
            .then((result) => {  
             console.log(result.data);
            //props.history.push('/admin/empleados' + data.id); 
            setModal(false); 
            //props.history.push('/admin/empleados');
            
            Swal.fire(
                'Listo',
                'Empleado Actualizado!',
                'success'
              );
            })
        .catch((error) => 
            console.log( error.response ) ); 


    }

    

    const onChange = (e) => {

        e.persist();

        agregarEmpleado({...empleado, [e.target.name] : e.target.value });
        //console.log(empleado);
    }
    

   
        return (
           <div className="content">        
               <Button className="btn-warning mr-1" onClick={toggle}>Editar</Button>
            <Modal className="special_modal" isOpen={modal} toggle={toggle}>
                <ModalHeader className="special_header" toggle={toggle}><h3>Editar Empleado</h3></ModalHeader>
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
        );
    
}

export default withRouter(EmpleadoEdit);


    
    