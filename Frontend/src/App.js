import React, { useEffect, useState } from 'react';

function App() {

  const [data, setData] = useState(null);
  useEffect(() => {
    fetch('http://localhost:5256/User/users', {
      method: 'GET',
    })
      .then(response => response.json())
      .then(data => {
        setData(data);
        console.log(data);
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
