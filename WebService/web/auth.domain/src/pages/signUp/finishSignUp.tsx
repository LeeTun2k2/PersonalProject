import EmailIcon from "@/assets/images/email.svg"
export const FinishSignUp = () => {
    return (
        <div className="h-screen">
            <div className="w-full py-8">
                <img className="mx-auto h-10 w-auto" src="https://tailwindui.com/img/logos/mark.svg?color=indigo&shade=600" alt="Your Company"/>
            </div>
            <div className="w-full bg-blue-500 py-4">
                <div className="w-full flex justify-center items-center py-4">
                    <hr className="w-16"/>
                    <img className="h-4 mx-4" alt="Email" src={EmailIcon}/>
                    <hr className="w-16"/>
                </div>
                <div>
                    <h1 className="text-white text-center uppercase text-lg tracking-widest">Thank you for signed up</h1>
                    <h2 className="text-white text-center text-3xl font-bold py-8">Verify your E-mail Address</h2>
                </div>
            </div>
            <div className="py-8">
                <p className="text-center">
                    We have sent an confirmation link to your email address. Please check your email to verify you account.
                </p>
                <p className="text-center font-bold text-2xl py-4">
                    Thank you !
                </p>
            </div>
            <div className="flex justify-center">
                <div>
                    <a className="block bg-blue-500 rounded-md text-white text-lg font-bold px-16 py-2 hover:scale-105 transition-all ease-in-out duration-300" href="sign-in">Sign In</a>
                </div>
            </div>
        </div>
    )
}