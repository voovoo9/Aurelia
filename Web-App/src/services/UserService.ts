import { User } from "../entities/User";
import { API_BASE_ENDPOINT } from '../shared/constants';

export const fetchUsers = () => {
  // console.log('fetch GET');
  return fetch(API_BASE_ENDPOINT)
    .then(response => {
      return response.json()
      .then(data => {
          console.log(data)
         return data;
        })
    })
    // .then(response => response.map(item =>new User(item.id, item.email, item.firstName, item.lastName))
    // );
};

export const registerUser = (model) => {

  return fetch(API_BASE_ENDPOINT, {
  method: "POST",
  body: JSON.stringify(model),
  headers: {
      'Content-Type': 'application/json',
  }
  })
  
  .then(function(response){
  return response.json()
  .then(data => {return data})
  .catch( error => {return })
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


export const fetchUsersById = (id) => {
  console.log('fetch GET');
  return fetch(API_BASE_ENDPOINT + "/" + id)
    .then(response => {
      return response.json()
      .then(data => {
        console.log(data)
         return data;
        })
    })
    // .then(response => response.map(item =>new User(item.id, item.email, item.firstName, item.lastName))
    // );
};
