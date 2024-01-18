import React, { useEffect, useState } from 'react';

function App() {

  const [data, setData] = useState("null");
  useEffect(() => {
    fetch('http://localhost:5256/api/users')
      .then(response => response.text())
      .then(d => {
        setData(d);
        console.log(d);
      }
      )
      .catch(error => console.log(error))
  }, []);

  return (
    <>
      <div>{data}</div>
    </>
  );
}

export default App;
