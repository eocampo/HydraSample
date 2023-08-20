import * as React from 'react'

export default function SampleCard() {

  const [message, setMessage] = React.useState('Hello, Hydra!');
  const [count, setCount] = React.useState(1);

  return (
    <div className="card shadow-2">
      <div className="card-header">
        <h1>{message}</h1>
      </div>
      <div className="card-body">
        <p>Aquí un ejemplo <span>{count}</span></p>
        <button role="button"
          className="btn btn-primary text-white"
          onClick={() => { setCount(count + 1) }}
        >
          Click me!
        </button>
      </div>
    </div>
  )
}
