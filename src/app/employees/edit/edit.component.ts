import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/models/employee.model';
import { EmployeeService } from 'src/app/services/employee.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.scss']
})
export class EditComponent implements OnInit {
id!: number;
header!:string;
employee: Employee = {
  id: 0,
  name: '',
  phone: 0
}
  employee1: Employee | undefined;
  //employee: Employee | undefined;
  constructor(private router: Router, private route: ActivatedRoute, private employeeService: EmployeeService) { }

  ngOnInit(): void {
    Number(this.route.snapshot.paramMap.get('id'));
    this.header = this.id === 0? 'Add Employee': 'Edit Employee';

    if(this.id != 0){
      this.employee1 = this.employeeService.onGetEmployee(this.id);
    }
  }
  onSubmit(form: NgForm){
    let employee: Employee = {
      id: form.value.id,
      name: form.value.name,
      phone: form.value.phone

    }

    if(this.id === 0)
    {
      this.employeeService.onUpdate(employee);
    }

    this.employeeService.onAdd(employee);
    this.router.navigateByUrl('');
  }
}
