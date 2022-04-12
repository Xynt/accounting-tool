import React from "react"
import { Link } from "react-router-dom"

class Navbar extends React.Component<any, any> {

  constructor(props: any) {
    super(props)
    this.state = {
      accountsHover: false,
      recordsHover: false
    }
  }

  toggleAccountsHover = () => {
    this.setState({ accountsHover: !this.state.accountsHover });
  }

  toggleRecordsHover = () => {
    this.setState({ recordsHover: !this.state.recordsHover });
  }

  render(): any {
    const flexStyles: any = {
      display: 'flex',
      flexDirection: 'row',
      justifyContent: 'center',
      alignItems: 'center',
      gap: '20px',
      backgroundColor: '#cccccc',
      height: '30px'
    }

    const linkNormalStyle = { color: '#383838', textDecoration: 'none' }
    const linkHoverStyle = { color: '#eeeeee', textDecoration: 'none' }

    const accountsLinkStyles = this.state.accountsHover ? linkHoverStyle : linkNormalStyle
    const recordsLinkStyles = this.state.recordsHover ? linkHoverStyle : linkNormalStyle

    return (
      <div style={flexStyles}>
        <Link to="/accounts" style={accountsLinkStyles} onMouseEnter={this.toggleAccountsHover} onMouseLeave={this.toggleAccountsHover}>Accounts</Link>
        <Link to="/records" style={recordsLinkStyles} onMouseEnter={this.toggleRecordsHover} onMouseLeave={this.toggleRecordsHover}>Records</Link>
      </div>
    )
  }
}

export default Navbar