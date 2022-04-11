import { Account } from "../models/Account";

export class AccountsRepository {

  public static getAccounts(): Account[] {
    // TODO: implement
    return [
      new Account('Kasse', 1000),
      new Account('Lohnkonto'),
      new Account('Sparkonto')
    ];
  }

  public static createAccount(): void {
    // TODO: implement
  }
}