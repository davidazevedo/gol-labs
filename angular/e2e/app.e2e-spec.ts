import { GolLabsTemplatePage } from './app.po';

describe('GolLabs App', function() {
  let page: GolLabsTemplatePage;

  beforeEach(() => {
    page = new GolLabsTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
