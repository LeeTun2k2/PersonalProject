import { createBrowserRouter } from "react-router-dom";
import { adminRoutes } from "./adminRoutes";
import { clientRoutes } from "./clientRoutes";

export const routers = createBrowserRouter([
    clientRoutes,
    adminRoutes
]);