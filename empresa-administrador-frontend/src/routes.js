
import Dashboard from "views/Dashboard.js";
import Icons from "views/Icons.js";
import Map from "views/Map.js";
import Notifications from "views/Notifications.js";
import Typography from "views/Typography.js";
import UserProfile from "views/UserProfile.js";
import EmpleadoList from './components/Empleado/EmpleadoList.js';
import EmpleadoAdd from "./components/Empleado/EmpleadoAdd.js";
import EmpleadoEdit from "./components/Empleado/EmpleadoEdit.js";

var routes = [
  {
    path: "/dashboard",
    name: "Dashboard",
    icon: "tim-icons icon-chart-pie-36",
    component: Dashboard,
    layout: "/admin"
  },
  // ruta de empleados
  {
    // lista de empleados
    path: '/empleados',
    name: "Empleados",
    icon: "tim-icons icon-pin",
    component: EmpleadoList,
    layout: "/admin"
  },
  {
    // agregar empleados
    path: '/empleado-add',
    component: EmpleadoAdd,
    layout: "/admin"
  },
  {
  path: '/empleado-edit',
  component: EmpleadoEdit,
  layout: "/admin"
  },
  {
    path: "/icons",
    name: "Icons",
    icon: "tim-icons icon-atom",
    component: Icons,
    layout: "/admin"
  },
  {
    path: "/map",
    name: "Map",
    icon: "tim-icons icon-pin",
    component: Map,
    layout: "/admin"
  },
  {
    path: "/notifications",
    name: "Notifications",
    icon: "tim-icons icon-bell-55",
    component: Notifications,
    layout: "/admin"
  },
  {
    path: "/user-profile",
    name: "User Profile",
    icon: "tim-icons icon-single-02",
    component: UserProfile,
    layout: "/admin"
  },
  {
    path: "/typography",
    name: "Typography",
    icon: "tim-icons icon-align-center",
    component: Typography,
    layout: "/admin"
  }
];
export default routes;
