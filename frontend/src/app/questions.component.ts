import { Component } from "@angular/core";
import { ApiService } from "./api.service";

@Component({
    selector: 'questions',
    templateUrl:  './questions.component.html',
    
})

export class QuestionsComponent {

    questions:any

    question = {
        questiontxt:"",
        answertxt:"",
        wrong1:"",
        wrong2:"",
        wrong3:"",
    }

    constructor(private api:ApiService) {}

    ngOnInit(){
        this.api.getQuestions().subscribe(res => {
            this.questions = res;
            console.log(res);
            console.log(this.questions)
        })
    }

    post(question:any) {
        this.api.postQuestion(question)
    }

}