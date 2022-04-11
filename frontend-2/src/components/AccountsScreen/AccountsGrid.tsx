import { AgGridReact } from 'ag-grid-react';
import { AccountsRepository } from './repositories/AccountsRepository';

import 'ag-grid-community/dist/styles/ag-grid.css';
import 'ag-grid-community/dist/styles/ag-theme-alpine.css';

const AccountsGrid = () => {

  const columnDefs = [
    { field: 'name' },
    { field: 'amount' }
  ]

  const rowData = AccountsRepository.getAccounts();

  return (
    <div className="ag-theme-alpine" style={{ height: 400, width: 602 }}>
      <AgGridReact
        rowData={rowData}
        columnDefs={columnDefs}>
      </AgGridReact>
    </div>
  )
}

export default AccountsGrid