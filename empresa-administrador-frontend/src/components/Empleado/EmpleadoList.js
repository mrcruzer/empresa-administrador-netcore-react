import React, {useState, useEffect } from "react";

import axios from "axios";

import Swal from "sweetalert2";

import { withRouter }  from "react-router-dom";

import EmpleadoAdd from "./EmpleadoAdd";

import EmpleadoEdit from './EmpleadoEdit';


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
    //const [cambio, asignarCambio] = useState('');

    const apiUrl = "https://localhost:44376/api/Empleado";

   

    useEffect(() => {
        const obtenerDatos = async () => {
            const resultado = await axios(apiUrl);
            asignarDatos(resultado.data);
            

        };
        obtenerDatos();

        //ModalEdit.toggle();
    },[datos]);



    const eliminarEmpleado = (id) => {

      const data = {nombre: datos.nombre, apellido: datos.apellido, direccion: datos.direccion, edad: parseInt(datos.edad), nomina: parseInt(datos.nomina), tipoNomina: datos.tipoNomina, telefono: parseInt(datos.telefono), email: datos.email, posicion: datos.posicion };

      const apiUrl = "https://localhost:44376/api/Empleado/" + id;


      //console.log(apiUrl);

      Swal.fire({
        title: 'Estas Seguro?',
        text: "Esta accion es irreversible!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Si, Eliminar!'
      }).then((result) => {
          if(result.value) {
            axios.delete(apiUrl, data)
            //loadData(); 
              Swal.fire(
                'Borrado!',
                'El Empleado ha sido eliminado.',
                'success'
              );
          
          }
        
      })
      //console.log(datos.id);
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
                                
                                <EmpleadoEdit item={item.id}/>
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
