export class User{
  id: number;
  email: string;
  firstName: string;
  lastName: string;

  constructor(id, email, firstName, lastName){
    this.id = id;
    this.email = email;
    this.firstName = firstName;
    this.lastName = lastName;
  }
}
