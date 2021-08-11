let { Repository } = require("./solution.js");
let {assert} = require('chai');

describe("Tests Repository", function () {
    describe("constructor", function () {
        it("Should set props correctly", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };

            let repo = new Repository(properties);

            assert.equal(JSON.stringify(properties), JSON.stringify(repo.props));
        });

        it("Should set data to a new Map", function () {
            let repo = new Repository({});
            let map = new Map();

            assert.equal(JSON.stringify(repo.data), JSON.stringify(map));
            assert.equal(repo.data.size, map.size);
        });

        it("nextId should return 0", function () {
            let repo = new Repository({});

            assert.equal(repo.nextId(), 0);
            assert.equal(repo.nextId(), 1);
        });
    });

    describe("count", function () {
        it("Should return correct value", function () {
            let repo = new Repository({});

            assert.equal(repo.count, 0);
            
            repo.add({});
            assert.equal(repo.count, 1);
        });
    });

    describe("add", function () {
        it("Should throw error if property is missing from entity", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
            };

            assert.throws(() => repo.add(entity), Error, 'Property birthday is missing from the entity!');
        });

        it("Should throw error if value of a property from entity isnt correct value", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: '22',
                birthday: new Date(1998, 0, 7)
            };

            assert.throws(() => repo.add(entity), TypeError, 'Property age is not of correct type!');
            // could add one more test
        });

        it("Should add item to data with correct id", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            repo.add(entity);
            let testMap = new Map();
            testMap.set(0, entity);

            assert.equal(testMap.has(0), repo.data.has(0));
            assert.equal(JSON.stringify(repo.data.get(0)), JSON.stringify(testMap.get(0)));
            // could add one more test
        });

        it("Should return correct id", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            assert.equal(repo.add(entity), 0);  
        });
    });

    describe("update", function () {
        it("Should throw error if data hasnt a key with given id", function () {
            let repo = new Repository({});

           assert.throws(() => repo.update(0, {}), Error, 'Entity with id: 0 does not exist!');
        });

        it("Should throw error if new entity hasnt got the needed properties", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            repo.add(entity);
            let entity1 = {
                name: "Pesho",
                age: 22
            }

            assert.throws(() => repo.update(0, entity1), Error, 'Property birthday is missing from the entity!');
        });

        it("Should throw error if new entity hasnt the correct values", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            repo.add(entity);
            let entity1 = {
                name: 15,
                age: 22,
                birthday: new Date(1998, 0, 7)
            }

            assert.throws(() => repo.update(0, entity1), TypeError, 'Property name is not of correct type!');
        });

        it("Should update the object at the correct index", function () {
            let properties = {
                name: "string",
                age: "number",
                birthday: "object"
            };
            let repo = new Repository(properties);

            let entity = {
                name: "Pesho",
                age: 22,
                birthday: new Date(1998, 0, 7)
            };

            repo.add(entity);
            let entity1 = {
                name: 'Gosho',
                age: 21,
                birthday: new Date(1990, 0, 7)
            }

            repo.update(0, entity1);

            assert.equal(JSON.stringify(repo.data.get(0)), JSON.stringify(repo.data.get(0)));
        });
    });

    describe("getId", function () {
        it("Should throw error if data doesnt have a key = id", function () {
            let repo = new Repository({});

            assert.throws(() => repo.getId(2), Error, 'Entity with id: 2 does not exist!');
        });

        it("Should return correct object if id exists", function () {
            let repo = new Repository({});
            repo.add({});
            
            assert.equal(JSON.stringify(repo.getId(0)), JSON.stringify({}));
        });
    });

    describe("del", function () {
        it("Should throw error if data doesnt have a key = id", function () {
            let repo = new Repository({});

            assert.throws(() => repo.del(2), Error, 'Entity with id: 2 does not exist!');
        });

        it("Should delete entity of the given index", function () {
            let repo = new Repository({});
            repo.add({});
            repo.del(0);
            
            assert.equal(repo.count, 0);
        });
    });
});
