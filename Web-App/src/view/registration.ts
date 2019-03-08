import { registerUser } from "../services/UserService";
import { fetchUsers, fetchUsersById } from "../services/UserService";
import { User } from "../entities/User";

export class Registration {
  public name: string = "";
  public surname: string = "";
  public email: string = "";
  public usersLoc: any;
  public rememberMe: false;

  public validate() {
    if (this.name === "" || this.surname === "") {
      alert("All fields are required!");
      return false;
    }
    return true;
  }

  public register() {
    if (this.validate()) {
      var model = {
        // "id": 0,
        email: this.email,
        firstName: this.name,
        lastName: this.surname
      };

      registerUser(model).then(function(user) {

        alert("Uspesno ste registrovani!");
        console.log(user);
      });
    }
  }

  
}

