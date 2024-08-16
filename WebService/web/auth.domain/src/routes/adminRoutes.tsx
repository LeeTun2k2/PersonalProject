import { AdminLayout } from "@/components/layouts/adminLayout";
import ErrorPage from "@/pages/404";
import { RouteObject } from "react-router-dom";

export const adminRoutes: RouteObject = {
    path: "/admin", 
    element: <AdminLayout />,
    errorElement: <ErrorPage />,
    children: [
        
    ],
};