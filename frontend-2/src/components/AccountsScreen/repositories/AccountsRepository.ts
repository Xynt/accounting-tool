import { Account } from "../models/Account";

export class AccountsRepository {

  public static getAccounts(): Account[] {
    // TODO: implement
    return [
      new Account('Kasse', true, 1000),
      new Account('Lohnkonto', false),
      new Account('Sparkonto', false)
    ];
  }

  public static createAccount(account: Account): void {
    // TODO: implement
    console.log(account)
  }
}