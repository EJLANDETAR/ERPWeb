import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { NgbModal, NgbModalRef } from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-create-account',
  templateUrl: './create-account.component.html',
  styles: []
})
export class CreateAccountComponent implements OnInit {

  frm: FormGroup;
  currentModal: NgbModalRef;

  constructor(private fb: FormBuilder, private ms: NgbModal) { }

  ngOnInit() {
    this.createForm();

  }

  createForm() {
    this.frm = this.fb.group({
      Email: ['', [Validators.required, Validators.email]],
      DireccionIP: ['']
    });

  }

  onOpenModal(content: any) {
    this.frm.reset();
    this.currentModal = this.ms.open(content, {backdrop: 'static'});
  }

}
