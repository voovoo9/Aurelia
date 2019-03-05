import { User } from "../entities/User";
import { API_BASE_ENDPOINT } from '../shared/constants';

export const fetchUsers = () => {
  console.log('fetch GET');
  return fetch(API_BASE_ENDPOINT)
    .then(response => {
      return response.json()
      .then(data => {
        return data;
        })
    })
    // .then(response => response.map(item =>new User(item.id, item.email, item.firstName, item.lastName))
    // );
};

export const fetchUser = (model) => {
  // const create = "/create"
  console.log("fetch POSTS")
  return fetch(API_BASE_ENDPOINT,{
    method: "POST",
    body: JSON.stringify(model)
  })
  .then(function(response){
    return response.json()
    .then(function(user){
      const {id, email, firstName, lastName} = user;
      return new User(id, email, firstName, lastName)
    })
    // .then(data => {
    //   console.log(data)
    //   return data;
    // })
  })
}

// export const deleteUser = (id) => {
//   console.log("deleteUser")
//   return fetch(API_BASE_ENDPOINT, {
//     method: "DELETE",
//     body: JSON.stringify(id)
//   })
//   .then(function(response){
//     return response.json()
//   })
// }
