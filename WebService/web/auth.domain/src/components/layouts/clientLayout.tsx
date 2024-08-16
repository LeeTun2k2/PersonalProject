import React from "react";
import { Outlet } from "react-router-dom";

export const ClientLayout: React.FC = () => {
    return (
        <div id="client">
            <Outlet />
        </div>
    );
};