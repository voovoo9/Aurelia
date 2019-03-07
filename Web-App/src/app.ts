import { Aurelia } from "aurelia-framework";
import { PLATFORM } from "aurelia-pal";
import { fetchUsers, fetchUser, fetchUsersById } from "./services/UserService";

export class App {
  public name: string = "";
  public surname: string = "";
  public email: string = "";
  public usersLoc: any;
  public rememberMe: false;


  public validate() {
    if (this.name ==="" || this.surname === "") {
      alert("All fields are required!");
      return false;
    }
    return true;
  }
  
  public register() {
    if (this.validate()) {

      var model = {
        // "id": 0,
        "email": this.email,
        "firstName": this.name,
        "lastName": this.surname,
      }
      
      fetchUser(model)
      .then(response => alert("Uspesno ste registrovani!"));
  }}
  
  attached(){
    fetchUsers()
    .then(users => {
      this.usersLoc = users;
      (document.getElementById("getUsers"));
    });

    
    fetchUsersById(2).then(result => console.log(result));
  }

}
