import SignInImage from "@/assets/images/signin.avif";
import { FormEvent } from "react";
import { useNavigate } from "react-router-dom";

export const SignUp = () => {
    const navigate = useNavigate();
    const handleSubmit = (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        navigate("/finish-sign-up");
    }
    return (
        <div className="flex h-screen">
            <div className="flex w-2/5 min-h-full flex-col justify-center px-6 py-12 lg:px-8">
                <div className="sm:mx-auto sm:w-full sm:max-w-sm">
                    <img className="mx-auto h-10 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600" alt="Your Company"/>
                    <h2 className="mt-4 text-center text-2xl font-bold leading-9 tracking-tight text-gray-900">Sign up a new account</h2>
                    <p className="text-center text-sm text-gray-500">
                        Have a account yet? {" "}
                        <a href="sign-in" className="font-semibold leading-6 text-indigo-600 hover:text-indigo-500">Sign in now</a>
                    </p>
                </div>

                <div className="mt-10 sm:mx-auto sm:w-full sm:max-w-sm">
                    <form className="space-y-6" onSubmit={handleSubmit}>
                        <div>
                            <label htmlFor="email" className="block text-sm font-medium leading-6 text-gray-900">Email address</label>
                            <div className="mt-2">
                            <input id="email" name="email" type="email" autoComplete="email" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <label htmlFor="password" className="block text-sm font-medium leading-6 text-gray-900">Password</label>
                            <div className="mt-2">
                                <input id="password" name="password" type="password" autoComplete="current-password" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <label htmlFor="confirmPassword" className="block text-sm font-medium leading-6 text-gray-900">Confirm password</label>
                            <div className="mt-2">
                                <input id="confirmPassword" name="confirmPassword" type="password" autoComplete="current-password" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <label htmlFor="name" className="block text-sm font-medium leading-6 text-gray-900">Name</label>
                            <div className="mt-2">
                                <input id="name" name="name" type="text" autoComplete="name" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <label htmlFor="phoneNumber" className="block text-sm font-medium leading-6 text-gray-900">Phone number</label>
                            <div className="mt-2">
                                <input id="phoneNumber" name="phoneNumber" type="tel" autoComplete="tel" required className="block w-full rounded-md border-0 py-1.5 px-2 text-gray-900 shadow-sm ring-1 ring-inset ring-gray-300 placeholder:text-gray-400 focus:ring-2 focus:ring-inset focus:ring-indigo-600 sm:text-sm sm:leading-6"/>
                            </div>
                        </div>
                        <div>
                            <button type="submit" className="flex w-full justify-center rounded-md bg-indigo-600 px-3 py-1.5 text-sm font-semibold leading-6 text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600 transition-all duration-1000 ease-in-out">Sign up</button>
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