import React, { useState } from "react";

import axios from "axios";

import Swal from "sweetalert2";

import { withRouter } from "react-router-dom";

import { 
    Button, 
    FormGroup,
    Input,
    Row, 
    Col, 
    Modal,
    ModalHeader,
    ModalBody,
    ModalFooter,
    Dropdown, 
    DropdownToggle, 
    DropdownMenu, 
    DropdownItem,
    UncontrolledDropdown
} from 'reactstrap';


function EmpleadoAdd(props) {

    const [empleado, agregarEmpleado] = useState({nombre: '', apellido: '', direccion: '', edad: '', nomina: '',  tipoNomina: '', telefono: '', email: '', posicion: ''});


        // Abrir Y Cerrar Modal
    const [modal, setModal] = useState(false);

    //const toggle = () => setModal(!modal);

        // Abrir y Cerrar Dropdown
    const [dropdownOpen, setDropdownOpen] = useState(false);

    //const toggleDropdown = () => setDropdownOpen(prevState => !prevState);

    //const toggleDropdown = () => setDropdownOpen(!dropdownOpen);

    //const toggle = () => setModal(!modal);

    const toggle = () => function(valor) {
        console.log(valor);
     }

    const apiUrl = "https://localhost:44376/api/Empleado";

    // useEffect(() => {
    //     const obtenerDatos = async () => {
    //     const resultado = await axios(apiUrl);
    //     agregarEmpleado(resultado.data);
    //     };
    //     obtenerDatos();
    //     //console.log(apiUrl);
    // },[apiUrl]);


    const insertarEmpleado = () => {
    
        //e.preventDefault();

    const data = {nombre: empleado.nombre, apellido: empleado.apellido, direccion: empleado.direccion, edad: parseInt(empleado.edad), nomina: parseInt(empleado.nomina), tipoNomina: empleado.tipoNomina, telefono: parseInt(empleado.telefono), email: empleado.email, posicion: empleado.posicion };

        axios.post(apiUrl, data)
             .then((result) => {  
                console.log(result.data)

                setModal(false); 

                Swal.fire(
                    'Listo',
                    'Empleado Creado!',
                    'success'
                  );
              })
              .catch((error) => 
                console.log( error.response ) ); 
        
    } 

    const onChange = (e) => {

        e.persist();

        agregarEmpleado({...empleado, [e.target.name]: e.target.value });
    }

    return (
        
        <div className="content">
            <Button className="btn-primary" onClick={toggle("Modal")}>Agregar Empleado</Button>
            <Modal className="special_modal" isOpen={modal} toggle={toggle}>
                <ModalHeader className="special_header" toggle={toggle}><h3>Agregar Empleado</h3></ModalHeader>
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
                                type="number" 
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
                                type="number" 
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
                        
                        <Dropdown isOpen={dropdownOpen} toggle={toggle(2)}>
                            
                                <DropdownToggle>
                                    Tipo De Nomina
                                    </DropdownToggle>
                               
                            <DropdownMenu>
                                <DropdownItem>Mensual</DropdownItem>
                                <DropdownItem>Quincenal</DropdownItem>
                            </DropdownMenu>
                            </Dropdown>
                            
                            {/* <Input 
                                type="text" 
                                name="tipoNomina"
                                id="tipoNomina" 
                                placeholder="Tipo De Nomina"
                                value={empleado.tipoNomina}
                                onChange={onChange}
                            /> */}
                        </FormGroup> 
                    </Col>
                </Row>
                <Row>
                    <Col className="md-6">
                        <FormGroup>
                            <Input 
                                type="number" 
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
                    <Button color="primary" onClick={() => insertarEmpleado()}>Agregar Empleado</Button>{' '}
                    <Button color="secondary" onClick={toggle}>Cancelar</Button>
                </ModalFooter>
        </Modal>
               
        </div>

    


                    
        
    );
}

export default withRouter(EmpleadoAdd);