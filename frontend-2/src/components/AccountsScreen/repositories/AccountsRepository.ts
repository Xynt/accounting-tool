import { Account } from "../models/Account";

export class AccountsRepository {

  private static accounts = [
    new Account('Kasse', true, 1000),
    new Account('Lohnkonto', false),
    new Account('Sparkonto', false)
  ];

  public static getAccounts(): Account[] {
    // TODO: implement
    return this.accounts
  }

  public static createAccount(account: Account): void {
    // TODO: implement
    this.accounts.push(account)
  }
}