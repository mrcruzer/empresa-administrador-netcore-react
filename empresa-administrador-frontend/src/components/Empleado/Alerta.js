import React from 'react';
import { Toast, ToastBody, ToastHeader } from 'reactstrap';


function Alerta() {
    return (

      <div className="p-3 bg-secondary my-2 rounded">
      <Toast>
        <ToastHeader>
          Reactstrap
        </ToastHeader>
        <ToastBody>
          This is a toast on a secondary background — check it out!
        </ToastBody>
      </Toast>
    </div>
    )
}

export default Alerta();