import { BrowserRouter as Router, Routes, Route } from 'react-router-dom'
import './App.css';
import AccountsScreen from './components/AccountsScreen/AccountsScreen';
import Navbar from './components/Navbar/Navbar';
import RecordsScreen from './components/RecordsScreen/RecordsScreen';

const App = () => {
  return (
    <div className="App">
      <Router>
        <Navbar />
        <Routes>
          <Route path="/accounts" element={<AccountsScreen />} />
          <Route path="/records" element={<RecordsScreen />} />
        </Routes>
      </Router>
    </div>
  );
}

export default App;
