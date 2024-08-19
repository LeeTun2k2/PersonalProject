import FacebookIcon from "@/assets/images/facebook.svg";
import GoogleIcon from "@/assets/images/google.svg";
import SignInImage from "@/assets/images/signin.avif";
import { FormEvent } from "react";
import { useNavigate } from "react-router-dom";

export const SignIn = () => {
    const navigate = useNavigate();
    const handleSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        navigate("/");
        alert("login success")
    }
    return (
        <div className="flex h-screen">
            <div className="flex w-2/5 min-h-full flex-col justify-center px-6 py-12 lg:px-8">
                <div className="sm:mx-auto sm:w-full sm:max-w-sm">
                    <img className="mx-auto h-10 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600" alt="Your Company"/>
                    <h2 className="mt-4 text-center text-2xl font-bold leading-9 tracking-tight text-gray-900">Sign in to your account</h2>
                    <p className="text-center text-sm text-gray-500">
                        Not a member? {" "}
                        <a href="sign-up" className="font-semibold leading-6 text-indigo-600 hover:text-indigo-500">Sign up now</a>
                    </p>
                </div>

                <div className="mt-10 sm:mx-auto sm:w-full sm:max-w-sm">
                    <form className="space-y-6" onSubmit={handleSubmit}>
                        <div>
                            <label htmlFor="email" className="block text-sm font-medium leading-6 text-gray-900">Email address</label>
                            <div className="mt-2">
                            <input id="email" name="email" type="email" autoComplete="email" required className="block w-full rounded-md border-0 py-1.5 px-2  text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <label htmlFor="password" className="block text-sm font-medium leading-6 text-gray-900">Password</label>
                            <div className="mt-2">
                                <input id="password" name="password" type="password" autoComplete="current-password" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <div className="text-sm flex justify-end">
                                <a href="forgot-password" className="font-semibold text-indigo-600 hover:text-indigo-500">Forgot password?</a>
                            </div>
                        </div>
                        <div>
                            <button type="submit" className="flex w-full justify-center rounded-md bg-indigo-600 px-3 py-1.5 text-sm font-semibold leading-6 text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600 transition-all duration-1000 ease-in-out">Sign in</button>
                        </div>
                        <div className="flex items-center">
                            <hr className="block w-1/4 border-gray-300"/>
                            <p className="text-center text-sm text-gray-500 w-1/2">Or continue with</p>
                            <hr className="block w-1/4 border-gray-300"/>
                        </div>
                        <div className="flex justify-between">
                            <div className="flex items-center justify-center w-5/12 h-10 rounded-md border border-gray-300 cursor-pointer hover:bg-gray-100 hover:scale-105 transition-all duration-300 ease-in-out" onClick={() => {alert('google')}}>
                                <img alt="google" src={GoogleIcon} className="w-6"/>
                                <p className="ml-1 text-sm font-medium leading-6 text-gray-900">Google</p>
                            </div>
                            <div className="flex items-center justify-center w-5/12 h-10 rounded-md border border-gray-300 cursor-pointer hover:bg-gray-100 hover:scale-105 transition-all duration-300 ease-in-out" onClick={() => {alert('facebook')}}>
                                <img alt="facebook" src={FacebookIcon} className="w-4"/>
                                <p className="ml-1 text-sm font-medium leading-6 text-gray-900">Facebook</p>
                            </div>
                        </div>
                    </form>                    
                </div>
            </div>
            <div className="w-3/5 bg-red-500">
                <img alt="Sign In Image" src={SignInImage} className="h-full object-cover" />
            </div>
        </div>
    )
}