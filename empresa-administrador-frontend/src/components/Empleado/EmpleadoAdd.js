import React, {useState, useEffect } from "react";

import axios from "axios";

import { withRouter } from "react-router-dom";

import { Button, Form, FormGroup, Label, Input, FormText, Row, Col } from 'reactstrap';




function EmpleadoAdd(props) {

    const [empleado, agregarEmpleado] = useState({nombre: '', apellido: '', direccion: '', edad: '', nomina: '',  tipoNomina: '', telefono: '', email: '', posicion: ''});

    const apiUrl = "https://localhost:44376/api/Empleado";

    const insertarEmpleado = (e) => {
        e.preventDefault();

        const data = {nombre: empleado.nombre, apellido: empleado.apellido, direccion: empleado.direccion, edad: parseInt(empleado.edad), nomina: parseInt(empleado.nomina), tipoNomina: empleado.tipoNomina, telefono: parseInt(empleado.telefono), email: empleado.email, posicion: empleado.posicion };

        axios.post(apiUrl, data)
              .then((result) => {  
                console.log(result.data)
                props.history.push('/empleados')  
              })
              .catch((error) => 
                console.log( error.result ) ); 
    } 

    const onChange = (e) => {
        e.persist();
        agregarEmpleado({...empleado, [e.target.name]: e.target.value });
    }
    return (
        
        <div className="content">
            <h1>Crear Un Usuario</h1>
            <Form onSubmit={insertarEmpleado}>
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
                <Button type="submit">Enviar</Button>
            </Form>
               
            
        </div>
                    
        
    );
}

export default withRouter(EmpleadoAdd);