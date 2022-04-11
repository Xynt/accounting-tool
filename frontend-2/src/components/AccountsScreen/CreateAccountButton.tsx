import { useState } from 'react';
import Popup from 'reactjs-popup';
import 'reactjs-popup/dist/index.css';
import { Account } from './models/Account';
import { AccountsRepository } from './repositories/AccountsRepository';

const CreateAccountButton = ({ accountCreated }: any) => {

  const [isPhysical, setIsPhysical] = useState(false)
  const [name, setName] = useState('')
  const [amount, setAmount] = useState(0)

  function addAccountClickHandler(): void {
    const account: Account = new Account(name, isPhysical, amount)
    AccountsRepository.createAccount(account) // TODO: await
    accountCreated()
  }

  return (
    <Popup
      trigger={<button className="button">Add Account</button>}
      modal
      nested
    >
      {(close: any) => (
        <div className="modal">
          <div className="actions">
            <p>Name:</p>
            <input onChange={(e: any) => setName(e.target.value)} />
            <p>Is physical</p>
            <input type="checkbox" onClick={(e: any) => setIsPhysical(e.target.checked)}></input>
            {isPhysical && <>
              <p>Amount:</p>
              <input type="number" onChange={(e: any) => setAmount(e.target.value)} />
            </>}
            <div>
              <button onClick={() => {
                addAccountClickHandler()
                close()
              }}>Create</button>
              <button onClick={() => {
                setIsPhysical(false)
                close()
              }}>Cancel</button>
            </div>
          </div>
        </div>
      )}
    </Popup>
  )
}

export default CreateAccountButton