import React from "react";
import { Duck } from "./ducks";

interface Props {
	duck: Duck;
}

const Duk = ({ duck }: Props) => {
	return <div>{duck.age}</div>;
};

export default Duk;
