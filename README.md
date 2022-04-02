# MB

3 files were created to create mvvm pattern design

1- Model --> The model contains 3 classes of User, Staff, and Admin, since the attribute  is similar between these classes.
I made an Inheritance, where the User class is the class of the Father, and the Class of Staff and Admin is inherited from the Class of the Father (sons).

Also, the model class contains 2 Overrides (method)-------->1-Override the ToString
                                                             2-Override the Equals(object)
                                                             


2- Model View -------------->  Through it he can add a user (user, stave, or admin), modify the user, or delete

3- View class---------------> it contains delegate


notice-->The model classes know nothing about other classes


4-main  class contain the menue to choice the method in Model View
