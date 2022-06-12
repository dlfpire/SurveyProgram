import 'bulma/css/bulma.min.css';
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import { useEffect, useState, useRef } from 'react';

export default function ConFormApi() {
	return (
		<BrowserRouter>
			<div className='ConForm'>
				<Routes>
					<Route path='/' element={<ConForm />} />
				</Routes>
			</div>
		</BrowserRouter>
	)
}

const ConForm = () => {
	const [info, setInfo] = useState(null);
	const [data, setData] = useState(null);
	const [show, setShow] = useState(false);

	useEffect(() => {
		fetch('http://localhost:3001/data')
			.then((res) => {
				return res.json()
			})
			.then((data) => {
				setTimeout(() => {
					let [info, ...form] = data[0];
					setInfo(info);
					setData(form);
				}, 2500);
			})
	}, [show])

	const Input = (props) => {
		let idx = props['idx'];
		return(
			<div style = {{padding: "20px"}}>
				<br/>
				<label className="label">{data[idx].Qtitle}
					<input className="input m-2" type="text"
						placeholder="입력해주세요" name={ "a" + idx }/>
				</label>
			</div>
		)
	}
	
	const Radio = (props) => {
		let idx = props['idx'];
		let cnt = idx;

		return(
			<>
				<div className="control" style = {{padding: "20px"}}>
					<span style={{fontWeight: "800"}}>{data[idx].Qtitle}</span>
					<br></br>
					<label className="radio">
						<input class = "m-2" type="radio" name={ "a" + idx } />
						{data[idx].Q0}
					</label>
					<br></br>
					<label className="radio">
						<input class = "m-2" type="radio" name={ "a" + idx } />
						{data[idx].Q1}
					</label>
					<br></br>
					<label className="radio">
						<input class = "m-2" type="radio" name={ "a" + idx } />
						{data[idx].Q2}
					</label>
					<br></br>
					<label className="radio">
						<input class = "m-2" type="radio" name={ "a" + idx } />
						{data[idx].Q3}
					</label>
				</div>
			</>
		)
	}

	const Check = (props) => {
		let idx = props['idx'];

		return(
			<>
				<div className="control" style = {{padding: "20px"}}>
				<span style={{fontWeight: "800"}}>{data[idx].Qtitle}</span>
					<br></br>
					<label className="checkbox">
						<input class = "m-2" type="checkbox" name={ "a" + idx } />
						{data[idx].Q4}
					</label>
					<br></br>
					<label className="checkbox">
						<input class = "m-2" type="checkbox" name={ "a" + idx } />
						{data[idx].Q5}
					</label>
					<br></br>
					<label className="checkbox">
						<input class = "m-2" type="checkbox" name={ "a" + idx } />
						{data[idx].Q6}
					</label>
					<br></br>
					<label className="checkbox">
						<input class = "m-2" type="checkbox" name={ "a" + idx } />
						{data[idx].Q7}
					</label>
				</div>
			</>
		)
	}

	const Header = () => {
		return (
		<>
			<section className="hero is-medium is-link">
				<div className="hero-body">
					<p className="title" style={{fontSize: "50px"}}>
					{info.FormTitle}
					</p>
					<p className="subtitle mt-2">
					(솔직하게 답변해주시기 바랍니다!)
					</p>
				</div>
			</section>
		</>
		)
	}
	
	const Selector = (props) => {
		let idx = props['idx'];
		let data = props['data'];

		if (data['type'] === '주관식형') return (<Input idx={idx} />);
		if (data['type'] === '복수선택형') return (<Check idx={idx} />);
		if (data['type'] === '단일선택형') return (<Radio idx={idx}></Radio>);

		return (<div></div>)
		
	}

	const LoadingBar = () => { 
		return (
			<div className="container" style={{padding: "400px"}}>
				<div className="p-8">
					<progress className="progress is-large is-info" max="100">60%</progress>
				</div>
			</div>
		)
	}
	
	const Form = () => {
		return (
			<>
				<Header />
				<div className="contaienr">
					{data.map((v, i) => { 
						return (
							<>
								<Selector data={v} idx={i} />
							</>
						)
					})}
				</div>
			</>
		)
	};

	const onclick = () => {
		if(window.confirm("제출하시겠습니까?")) {
			window.confirm("제출되었습니다.")
			setShow(!show)
		}
		else {
			return;
		}
	}

	return(
		<>
			{data == null && <LoadingBar /> }
			{data != null && <Form /> }
			{data != null &&
				<div className="buttons" style={{padding: "20px"}}>
				<button className="button is-info" onClick={onclick}>제출</button>
			</div>}
		</>
	)
}

