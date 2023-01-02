import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestErrorComponent } from './errors/test-error/test-error.component';
import { HomeComponent } from './home/home.component';
import { ListsComponent } from './lists/lists.component';
import { MemberDetailComponent } from './members/member-detail/member-detail.component';
import { MembersListComponent } from './members/members-list/members-list.component';
import { MessagesComponent } from './messages/messages.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'members', component: MembersListComponent},
  {path: 'members/:id', component: MemberDetailComponent},
  {path: 'lists', component: ListsComponent},
  {path: 'messages', component: MessagesComponent},
  {path: 'errors', component: TestErrorComponent},
  {path: '**', component: HomeComponent, pathMatch: 'full'} // wildcard,
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
