
import { Route, Routes } from 'react-router-dom';
import './App.css';
import Home from './Page/Home';
import Login from './Page/Login';
function App() {
  return (
   <>
   <Routes>
      <Route path='/' element={<Home/>} />
      <Route path='/login' element={<Login/>} />
   </Routes>
   
   </>
    
  );
}

export default App;
