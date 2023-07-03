import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";

function App() {
	const [activities, getActivities] = useState([]);

	useEffect(() => {
		axios.get("http://localhost:5000/api/test/").then((response) => {
			console.log(response);
			getActivities(response.data);
		});
	}, []);

	return (
		<div className="App">
			{activities.map((active: any, index) => (
				<div key={index}>{active.category}</div>
			))}
		</div>
	);
}

export default App;
