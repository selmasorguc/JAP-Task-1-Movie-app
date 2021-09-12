import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { User } from '../_models/user';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  user: User = { username: '', password:''};
  isLoggedIn = false;

  constructor(private userService: UserService, private toastr: ToastrService) { }

  ngOnInit(): void {
   
  }

  login() {
    this.userService.login(this.user).subscribe(response => {
      this.isLoggedIn = true;
      this.toastr.success("Hello");
    })
  }

}
