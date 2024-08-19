import EmailIcon from "@/assets/images/email.svg"
export const ConfirmSuccess = () => {
    return (
        <div className="h-screen">
            <div className="w-full py-8">
                <img className="mx-auto h-10 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600" alt="Your Company"/>
            </div>
            <div className="w-full bg-green-500 py-4">
                <div className="w-full flex justify-center items-center py-4">
                    <hr className="w-16"/>
                    <img className="h-4 mx-4" alt="Email" src={EmailIcon}/>
                    <hr className="w-16"/>
                </div>
                <div>
                    <h1 className="text-white text-center uppercase text-lg tracking-widest">Confirm successful</h1>
                    <h2 className="text-white text-center text-3xl font-bold py-8">You have confirmed your email successfully</h2>
                </div>
            </div>
            <div className="py-8">
                <p className="text-center">
                    Next step, please click on the Sign in button and feel free with our services.
                </p>
                <p className="text-center font-bold text-2xl py-4">
                    Thank you !
                </p>
            </div>
            <div className="flex justify-center">
                <div>
                    <a className="block bg-green-500 rounded-md text-white text-lg font-bold px-16 py-2 hover:scale-105 transition-all ease-in-out duration-300" href="sign-in">Sign In</a>
                </div>
            </div>
        </div>
    )
}