
import { fetchUsers, fetchUsersById } from "../services/UserService";
import { User } from "../entities/User";
export class ListOfUsers{
  public name: string = "";
  public surname: string = "";
  public email: string = "";
  public usersLoc: any;
  public rememberMe: false;

  public constructor() {
    fetchUsers().then(users => {
      this.usersLoc = users;
      document.getElementById("getUsers");
    });
    
    fetchUsersById(2).then(result => console.log(result));
  }
}
