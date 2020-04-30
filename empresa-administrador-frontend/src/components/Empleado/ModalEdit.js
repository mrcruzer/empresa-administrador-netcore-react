import React, {useState, useEffect } from 'react';

import axios from "axios";

import { withRouter } from 'react-router-dom';

function ModalEdit(props) {

    const [empleado, agregarEmpleado] = useState({nombre: '', apellido: '', direccion: '', edad: '', nomina: '',  tipoNomina: '', telefono: '', email: '', posicion: ''});

    const apiUrl = "https://localhost:44376/api/Empleado" + props.match.id;

    useEffect(() => {
        const obtenerDatos = async () => {
        const resultado = await axios(apiUrl);
        agregarEmpleado(resultado.data);
        };
        obtenerDatos();
        
    },[]);

    const EditarEmpleado = (e) => {

        e.preventDefault();

        const data = {id: empleado.id, nombre: empleado.nombre, apellido: empleado.apellido, direccion: empleado.direccion, edad: parseInt(empleado.edad), nomina: parseInt(empleado.nomina), tipoNomina: empleado.tipoNomina, telefono: parseInt(empleado.telefono), email: empleado.email, posicion: empleado.posicion };

        axios.put(apiUrl, data)
            .then((result) => {  
             console.log(result.data);
            //props.history.push('/admin/empleados' + data.id);  
            })
        .catch((error) => 
            console.log( error.response ) ); 


    }

    const onChange = (e) => {

        e.persist();

        agregarEmpleado({...empleado, [e.target.name] : e.target.value });
        console.log(empleado);
    }
    

    // componentWillReceiveProps(nextProps) {
    //     this.setState({
    //         title: nextProps.title,
    //         msg: nextProps.msg,
    //     });
    // }

    // titleHandler(e) {
    //     this.setState({ title: e.target.value });
    // }

    // msgHandler(e) {
    //     this.setState({ msg: e.target.value });
    // }

    // handleSave() {
    //     const item = this.state;
    //     this.props.saveModalDetails(item)
    // }

   
        return (
            <div className="modal fade" id="exampleModal" tabIndex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                <div className="modal-dialog" role="document">
                    <div className="modal-content">
                        <div className="modal-header">
                            <h5 className="modal-title" id="exampleModalLabel">Editar Empleado</h5>
                            <button type="button" className="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button>
                        </div>
                        <div className="modal-body">
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
                            
                            
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-dismiss="modal">Cerrar</button>
                            <button type="button" className="btn btn-primary" data-dismiss="modal" onClick={EditarEmpleado}>Guardar</button>
                        </div>
                    </div>
                </div>
            </div>
        );
    
}

export default withRouter(ModalEdit);


    
    