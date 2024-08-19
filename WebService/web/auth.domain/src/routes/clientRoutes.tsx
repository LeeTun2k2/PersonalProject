import { ClientLayout } from "@/components";
import ErrorPage from "@/pages/404";
import { ForgotPassword } from "@/pages/forgotPassword";
import { FinishForgotPassword } from "@/pages/forgotPassword/finishForgotPassword";
import { ForgotPasswordFailure } from "@/pages/forgotPassword/forgotpasswordFailure";
import { ForgotPasswordSuccess } from "@/pages/forgotPassword/forgotPasswordSuccess";
import { RequestConfirmation } from "@/pages/requestConfirmation";
import { ConfirmFailure } from "@/pages/requestConfirmation/confirmFailure";
import { ConfirmSuccess } from "@/pages/requestConfirmation/confirmSuccess";
import { SignIn } from "@/pages/signIn";
import { SignUp } from "@/pages/signUp";
import { FinishSignUp } from "@/pages/signUp/finishSignUp";
import { RouteObject } from "react-router-dom";

export const clientRoutes: RouteObject = {
    path: "/", 
    element: <ClientLayout />,
    errorElement: <ErrorPage />,
    children: [
        {
            path: "",
            element: <SignIn/>
        },
        {
            path: "sign-in",
            element: <SignIn/>
        },
        {
            path: "sign-up",
            element: <SignUp/>
        },
        {
            path: "forgot-password",
            element: <ForgotPassword/>
        },
        {
            path: "finish-sign-up",
            element: <FinishSignUp/>
        },
        {
            path: "confirm-success",
            element: <ConfirmSuccess/>
        },
        {
            path: "confirm-failure",
            element: <ConfirmFailure/>
        },
        {
            path: "request-confirm",
            element: <RequestConfirmation/>
        },
        {
            path: "finish-forgot-password",
            element: <FinishForgotPassword/>
        },
        {
            path: "forgot-password-success",
            element: <ForgotPasswordSuccess/>
        },
        {
            path: "forgot-password-failure",
            element: <ForgotPasswordFailure/>
        }
    ],
};