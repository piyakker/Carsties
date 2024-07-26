import React from "react";
import { AiOutlineCar } from "react-icons/ai";
import { MdAccountCircle } from "react-icons/md";
import Search from "./Search";
import Logo from "./Logo";

export default function Navbar() {
  return (
    <header
      className="
    sticky top-0 z-50 flex justify-between bg-white p-5 items-center text-gray-800 shadow-md"
    >
      <Logo />
      <Search />
      <div className="flex items-center gap-2 text-3xl font-semibold">
        <MdAccountCircle size={34} />
        <div>Login</div>
      </div>
    </header>
  );
}
