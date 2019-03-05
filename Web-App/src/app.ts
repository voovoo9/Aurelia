import { Aurelia } from "aurelia-framework";
import { PLATFORM } from "aurelia-pal";
import { fetchUsers, fetchUser } from "./services/UserService";

export class App {
  public name: string = "";
  public surname: string = "";
  public email: string = "";
  public usersLoc: any;


  public validate() {
    if (this.name ==="" || this.surname === "") {
      alert("All fields are required!");
      return false;
    }
    return true;
  }
  
  public register() {
    if (!this.validate()) {
      return;
    } else {
      var model = {
        // "id": 0,
        "email": this.email,
        "firstName": this.name,
        "lastName": this.surname,
      }
      fetchUser(model)
      .then(response => {
        console.log(response);
      })
    }
    
  }
  
  attached(){
    fetchUsers()
    .then(users => {
      this.usersLoc = users;
      document.getElementById(users)
    });

  }

}
