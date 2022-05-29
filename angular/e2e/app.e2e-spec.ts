import { UserModuleTemplatePage } from './app.po';

describe('UserModule App', function() {
  let page: UserModuleTemplatePage;

  beforeEach(() => {
    page = new UserModuleTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
