import { Aurelia } from "aurelia-framework";
import { PLATFORM } from "aurelia-pal";
import { Router, RouterConfiguration } from "aurelia-router";

export class App {
  router: Router;

  configureRouter(config: RouterConfiguration, router: Router): void {
    this.router = router;
    config.title = "Aurelia";
    config.options.pushState = true;
    config.options.root = "/";
    config.map([
      {
        route: ["", "home"],
        name: "home",
        moduleId: PLATFORM.moduleName("./view/home"),
        nav: true
      },
      {
        route: "registration",
        name: "registration",
        moduleId: PLATFORM.moduleName("./view/registration")
        // nav: true
      },
      {
        route: "listOfUsers",
        name: "listOfUsers",
        moduleId: PLATFORM.moduleName("./view/listOfUsers"),
        nav: true,
        title: "List of users"
      }
    ]);
  }
}
