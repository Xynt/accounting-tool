import { AgGridReact } from 'ag-grid-react';
import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-alpine.css';
import { useEffect } from 'react';

const AccountsGrid = ({ accounts }: any) => {

  const columnDefs = [
    { field: 'name' },
    { field: 'amount' }
  ]

  return (
    <div className="ag-theme-alpine" style={{ height: 400, width: 602 }}>
      <AgGridReact
        rowData={accounts}
        columnDefs={columnDefs}>
      </AgGridReact>
    </div>
  )
}

export default AccountsGrid