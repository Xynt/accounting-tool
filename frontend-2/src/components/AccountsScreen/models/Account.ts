export class Account {
  name: string;
  amount: number;
  isPhysical: boolean;

  constructor(name: string, isPhysical: boolean, amount?: number) {
    this.name = name;
    this.isPhysical = isPhysical;
    this.amount = amount ?? 0;
  }
}