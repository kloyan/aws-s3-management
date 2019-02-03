import { Routes, RouterModule } from '@angular/router';
import { NgModule } from '@angular/core';

import { RegisterComponent } from './register/register.component';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'register',
        pathMatch: 'full'
    },

    {
        path: 'register',
        component: RegisterComponent
    }
];

@NgModule({
  imports: [ RouterModule.forChild(routes) ],
  exports: [ RouterModule ]
})
export class AccountRoutingModule { }