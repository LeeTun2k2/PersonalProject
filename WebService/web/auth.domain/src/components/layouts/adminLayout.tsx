import React from "react";
import { Outlet } from "react-router-dom";

export const AdminLayout: React.FC = () => {
    return (
        <div id="admin">
            <Outlet />
        </div>
    );
};