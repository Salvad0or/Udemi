import React, { useEffect, useState } from "react";
import "./App.css";
import axios from "axios";
import { List, ListItem, Button } from "semantic-ui-react";
import "./button.module.css";

function App() {
	const [activities, getActivities] = useState([]);

	useEffect(() => {
		axios.get("http://localhost:5000/api/test/").then((response) => {
			console.log(response);
			getActivities(response.data);
		});
	}, []);

	return (
		<>
			<List>
				{activities.map((active: any, index) => (
					<ListItem key={index}>{active.category}</ListItem>
				))}
			</List>

			<Button primary>Primary</Button>
		</>
	);
}

export default App;
