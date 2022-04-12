import { hover } from "@testing-library/user-event/dist/hover"
import { Link } from "react-router-dom"

const Navbar = () => {

  const flexStyles: any = {
    display: 'flex',
    flexDirection: 'row',
    justifyContent: 'center',
    alignItems: 'center',
    gap: '20px',
    backgroundColor: '#cccccc',
    height: '30px'
  }

  const linkStyles: any = {
    color: '#383838',
    textDecoration: 'none',
    "&:hover": {
      color: '#000000'
    }
  }

  return (
    <div style={flexStyles}>
      <Link to="/accounts" style={linkStyles}>Accounts</Link>
      <Link to="/records" style={linkStyles}>Records</Link>
    </div>
  )
}

export default Navbar