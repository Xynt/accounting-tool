import { useState } from 'react';
import AccountsGrid from './AccountsGrid';
import CreateAccountButton from './CreateAccountButton';
import { AccountsRepository } from './repositories/AccountsRepository';

const AccountsScreen = () => {

  const [accounts, setAccounts] = useState(AccountsRepository.getAccounts());

  const accountCreated = () => {
    console.log('account created')
    console.log(accounts)
    setAccounts(AccountsRepository.getAccounts())
    console.log(accounts)
  }

  return (
    <>
      <h1>Accounts</h1>
      <CreateAccountButton accountCreated={accountCreated} />
      <AccountsGrid accounts={accounts} />
    </>
  )
}

export default AccountsScreen